'''
function in dll that return non pod type cause crash when C# DllImport


example:

"IMGUI_API ImVec2        GetWindowPos();"

//
// constructor make non pod type
//
struct ImVec2
{
    float     x, y;
    ImVec2()  { x = y = 0.0f; }
    ImVec2(float _x, float _y) { x = _x; y = _y; }
};

# work around

//
// alternative pod type.
//
struct PodImVec2
{
    float x, y;
    float operator[](size_t idx) const
    {
        //IM_ASSERT(idx <= 1);
        return (&x)[idx];
    }
};

//
// add implicit auto conversion to ImVec2
//
struct ImVec2
{
    // to PodImVec2
    operator PodImVec2() const { return PodImVec2{x, y}; }

    // from PodImVec2
    ImVec2(const PodImVec2 &v) : x(v.x), y(v.y) {}
    ImVec2 &operator=(const PodImVec2 &v)
    {
        x = v.x;
        y = v.y;
        return *this;
    }
};

and replace ImVec2 that function returned to PodImVec2(this script)

example:

"IMGUI_API PodImVec2        GetWindowPos();"
'''
import re
import pathlib

HERE = pathlib.Path(__file__).absolute().parent
IMGUI_DIR = HERE / '../dependencies/imgui'
HEADERS = [
    IMGUI_DIR / 'imgui.h',
    IMGUI_DIR / 'imgui_internal.h',
]
RE_HEADER = re.compile(r'IMGUI_API ImVec2\b')
SOURCES = [
    IMGUI_DIR / 'imgui.cpp',
    IMGUI_DIR / 'imgui_draw.cpp',
    IMGUI_DIR / 'imgui_widgets.cpp',
]
RE_SOURCE = re.compile(r'^ImVec2\b', re.MULTILINE)


def main():
    for header in HEADERS:
        with open(header) as r:
            src = r.read()
        with open(header, 'w', newline='\n') as w:
            w.write(RE_HEADER.sub('IMGUI_API PodImVec2', src))
    for source in SOURCES:
        with open(source) as r:
            src = r.read()
        with open(source, 'w', newline='\n') as w:
            w.write(RE_SOURCE.sub('PodImVec2', src))


if __name__ == '__main__':
    main()

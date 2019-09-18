#pragma once

struct PodImVec2
{
    float x, y;
    float operator[](size_t idx) const
    {
        //IM_ASSERT(idx <= 1);
        return (&x)[idx];
    }
};

#define IM_VEC2_CLASS_EXTRA                                \
    operator PodImVec2() const { return PodImVec2{x, y}; } \
    ImVec2(const PodImVec2 &v) : x(v.x), y(v.y) {}         \
    ImVec2 &operator=(const PodImVec2 &v)                  \
    {                                                      \
        x = v.x;                                           \
        y = v.y;                                           \
        return *this;                                      \
    }

#define IMGUI_API __declspec(dllexport)
#define IMGUI_IMPL_API __declspec(dllexport)

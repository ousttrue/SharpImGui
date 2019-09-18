#include <imgui.h>
#include <iostream>

#define PRINT_OFFSET(field) std::cout << offsetof(ImGuiIO, field) << std::endl

int main()
{
    std::cout << std::is_pod<ImVec2>::value << std::endl;
    std::cout << std::is_pod<PodImVec2>::value << std::endl;

    PRINT_OFFSET(MouseDrawCursor);
    return 0;
}

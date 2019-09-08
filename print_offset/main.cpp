#include <imgui.h>
#include <iostream>

int main()
{
    std::cout << offsetof(ImGuiIO, ConfigFlags) << std::endl;
    std::cout << offsetof(ImGuiIO, UserData) << std::endl;
    std::cout << offsetof(ImGuiIO, Fonts) << std::endl;
    std::cout << offsetof(ImGuiIO, MouseWheel) << std::endl;
    return 0;
}

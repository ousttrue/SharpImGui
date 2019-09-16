#include <imgui.h>
#include <iostream>

#define PRINT_OFFSET(field) std::cout << offsetof(ImGuiIO, field) << std::endl

int main()
{
    PRINT_OFFSET(MouseDrawCursor);
    return 0;
}

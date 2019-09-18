set(SUB_NAME print_offset)
set(DEP_DIR ${CMAKE_CURRENT_LIST_DIR}/../dependencies)

file(GLOB IMGUI_SOURCES
    ${DEP_DIR}/imgui/imgui.cpp
    ${DEP_DIR}/imgui/imgui_draw.cpp
    ${DEP_DIR}/imgui/imgui_demo.cpp
    ${DEP_DIR}/imgui/imgui_widgets.cpp
    ${DEP_DIR}/imgui/examples/imgui_impl_win32.cpp
    ${DEP_DIR}/imgui/examples/imgui_impl_dx11.cpp
)
add_executable(${SUB_NAME} main.cpp
    ${IMGUI_SOURCES}
    )

target_include_directories(${SUB_NAME} PUBLIC 
    ${DEP_DIR}/imgui
    ../build_imgui
    )

target_compile_definitions(${SUB_NAME} PUBLIC 
    IMGUI_DISABLE_OBSOLETE_FUNCTIONS=1
    IMGUI_USER_CONFIG=<imconfig_dll.h>
    )

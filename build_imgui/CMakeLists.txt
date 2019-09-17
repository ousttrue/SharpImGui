set(SUB_NAME imgui)
set(DEP_DIR ${CMAKE_CURRENT_LIST_DIR}/../dependencies)


#general settings
file(GLOB IMGUI_SOURCES
    ${DEP_DIR}/imgui/imgui.cpp
    ${DEP_DIR}/imgui/imgui_draw.cpp
    ${DEP_DIR}/imgui/imgui_demo.cpp
    ${DEP_DIR}/imgui/imgui_widgets.cpp
    ${DEP_DIR}/imgui/examples/imgui_impl_win32.cpp
    ${DEP_DIR}/imgui/examples/imgui_impl_dx11.cpp
    extras.cpp
)

add_library(${SUB_NAME} SHARED ${IMGUI_SOURCES})

target_compile_definitions(${SUB_NAME} PUBLIC 
    IMGUI_DISABLE_OBSOLETE_FUNCTIONS=1
    IMGUI_USER_CONFIG=<imconfig_dll.h>
    )

target_compile_options(${SUB_NAME} PUBLIC
    # -Wno-c++11-narrowing
    )

target_include_directories(${SUB_NAME} PUBLIC
    .
    ${DEP_DIR}
    ${DEP_DIR}/imgui/examples
    ${DEP_DIR}/imgui
)

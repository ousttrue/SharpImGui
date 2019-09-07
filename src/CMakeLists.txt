set(DEP_DIR ${CMAKE_CURRENT_LIST_DIR}/../dependencies)


#general settings
file(GLOB IMGUI_SOURCES
    ${DEP_DIR}/cimgui/cimgui.cpp
    ${DEP_DIR}/imgui/imgui.cpp
    ${DEP_DIR}/imgui/imgui_draw.cpp
    ${DEP_DIR}/imgui/imgui_demo.cpp
    ${DEP_DIR}/imgui/imgui_widgets.cpp
    extras.cpp
)

set(IMGUI_STATIC "no" CACHE STRING "Build as a static library")
add_library(cimgui SHARED ${IMGUI_SOURCES})

target_compile_definitions(cimgui PUBLIC IMGUI_DISABLE_OBSOLETE_FUNCTIONS=1)

target_include_directories(cimgui PUBLIC 
    ${DEP_DIR}/cimgui
    ${DEP_DIR}
    ${DEP_DIR}/imgui/examples
    ${DEP_DIR}/imgui
)
set_target_properties(cimgui PROPERTIES PREFIX "")

#install
install(TARGETS cimgui
    RUNTIME DESTINATION  .
    LIBRARY DESTINATION  .
    ARCHIVE DESTINATION  .
)

#test
set(CIMGUI_TEST "no" CACHE STRING "Enable compilation of a test unit based on imgui null")

if (CIMGUI_TEST)
  add_subdirectory(test)
endif ()

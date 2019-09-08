set(DEP_DIR ${CMAKE_CURRENT_LIST_DIR}/../dependencies)

add_executable(print_offset main.cpp)

target_include_directories(print_offset PUBLIC 
    ${DEP_DIR}/imgui
)

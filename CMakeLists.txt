cmake_minimum_required(VERSION 3.0.0)
project(cimgui VERSION 0.1.0)

include(CTest)
enable_testing()

subdirs(build_cimgui print_offset)

set(CPACK_PROJECT_NAME ${PROJECT_NAME})
set(CPACK_PROJECT_VERSION ${PROJECT_VERSION})
include(CPack)

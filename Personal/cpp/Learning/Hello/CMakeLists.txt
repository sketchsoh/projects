cmake_minimum_required(VERSION 3.16)
project(Hello)

if(NOT CMAKE_BUILD_TYPE)
  set(default_build_type "Debug")
  message(STATUS "Set the build type to `${default_build_type}` as none was specified.")
  set(CMAKE_BUILD_TYPE ${default_build_type} CACHE STRING "Chooce the build type." FORCE)
  set_property(CACHE CMAKE_BUILD_TYPE PROPERTY STRINGS
  "Debug" "Release" "MinSizeRel" "RelWithDebInfo")
endif()
message(STATUS "Hello Build Type: ${CMAKE_BUILD_TYPE}")

# Set the version for Hello
set(Hello_Version_Major 0)
set(Hello_Version_Minor 1)
set(Hello_Version_Patch 0)
set(Hello_Version_Status "-dev")
set(PROJECT_VERSION
  "${Hello_Version_Major}.${Hello_Version_Minor}.${Hello_Version_Patch}${Hello_Version_Status}"
)
message(STATUS "${PROJECT_NAME} version: ${PROJECT_VERSION}")

add_executable(
  Hello
  main.cpp
)

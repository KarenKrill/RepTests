# CMakeList.txt: проект CMake для SomeNativeLib; включите исходный код и определения,
# укажите здесь логику для конкретного проекта.
#

# Добавьте источник в исполняемый файл этого проекта.
#add_executable (SomeNativeLib   "SomeApi.h" "SomeApi.cpp" "pch.h" "pch.cpp" "framework.h" "dllmain.cpp")
add_library (SomeNativeLib SHARED "SomeApi.h" "SomeApi.cpp" "pch.h" "pch.cpp" "framework.h" "dllmain.cpp")

if (CMAKE_VERSION VERSION_GREATER 3.12)
  set_property(TARGET SomeNativeLib PROPERTY CXX_STANDARD 20)
endif()

# TODO: Добавьте тесты и целевые объекты, если это необходимо.

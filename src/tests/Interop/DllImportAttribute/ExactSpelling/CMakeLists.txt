project (ExactSpellingNative)
include ("${CLR_INTEROP_TEST_ROOT}/Interop.cmake")
include ("${CLR_INTEROP_TEST_ROOT}/Interop.cmake")
set(SOURCES ExactSpellingNative.cpp)

# add the executable
add_library (ExactSpellingNative SHARED ${SOURCES})
target_link_libraries(ExactSpellingNative PRIVATE ${LINK_LIBRARIES_ADDITIONAL})

# add the install targets
install (TARGETS ExactSpellingNative DESTINATION bin)



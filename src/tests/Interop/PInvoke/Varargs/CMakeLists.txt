project (VarargsNative)
include ("${CLR_INTEROP_TEST_ROOT}/Interop.cmake")
set(SOURCES VarargsNative.cpp )

# add the executable
add_library (VarargsNative SHARED ${SOURCES})
target_link_libraries(VarargsNative PRIVATE ${LINK_LIBRARIES_ADDITIONAL})

# add the install targets
install (TARGETS VarargsNative DESTINATION bin)

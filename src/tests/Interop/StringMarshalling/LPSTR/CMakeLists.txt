set(SOURCES LPStrTestNative.cpp )
include ("${CLR_INTEROP_TEST_ROOT}/Interop.cmake")

# add the executable
add_library (LPStrTestNative SHARED ${SOURCES})
target_link_libraries(LPStrTestNative PRIVATE ${LINK_LIBRARIES_ADDITIONAL})

# add the install targets
install (TARGETS LPStrTestNative DESTINATION bin)

project (MarshalBoolArrayNative)
include ("${CLR_INTEROP_TEST_ROOT}/Interop.cmake")
set(SOURCES MarshalBoolArrayNative.cpp)

# add the executable
add_library (MarshalBoolArrayNative SHARED ${SOURCES})
target_link_libraries(MarshalBoolArrayNative PRIVATE ${LINK_LIBRARIES_ADDITIONAL})

# add the install targets
install (TARGETS MarshalBoolArrayNative DESTINATION bin)



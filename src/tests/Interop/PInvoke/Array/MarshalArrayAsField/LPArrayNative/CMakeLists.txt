
project (MarshalArrayByValArrayNative)
include ("${CLR_INTEROP_TEST_ROOT}/Interop.cmake")
include_directories("../..")
include ("${CLR_INTEROP_TEST_ROOT}/Interop.cmake")
set(SOURCES
    MarshalArrayByValArrayNative.cpp
)

# add the executable
add_library (MarshalArrayByValArrayNative SHARED ${SOURCES})
target_link_libraries(MarshalArrayByValArrayNative PRIVATE ${LINK_LIBRARIES_ADDITIONAL})
# add the install targets
install (TARGETS MarshalArrayByValArrayNative DESTINATION bin)

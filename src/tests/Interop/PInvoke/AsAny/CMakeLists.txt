project (AsAnyNative)
include ("${CLR_INTEROP_TEST_ROOT}/Interop.cmake")
set(SOURCES
    AsAnyNative.cpp
)
if(CLR_CMAKE_HOST_WIN32)
    list(APPEND LINK_LIBRARIES_ADDITIONAL
        OleAut32.lib
    )
endif(CLR_CMAKE_HOST_WIN32)
# add the executable
add_library (AsAnyNative SHARED ${SOURCES})
target_link_libraries(AsAnyNative PRIVATE ${LINK_LIBRARIES_ADDITIONAL})
# add the install targets
install (TARGETS AsAnyNative DESTINATION bin)

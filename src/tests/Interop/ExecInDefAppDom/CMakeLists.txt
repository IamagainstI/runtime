project (ExecInDefAppDomDll)
include ("${CLR_INTEROP_TEST_ROOT}/Interop.cmake")
set(SOURCES ExecInDefAppDomDll.cpp )

# add the executable
add_library (ExecInDefAppDomDll SHARED ${SOURCES})
target_link_libraries(ExecInDefAppDomDll PRIVATE ${LINK_LIBRARIES_ADDITIONAL})

# add the install targets
install (TARGETS ExecInDefAppDomDll DESTINATION bin)

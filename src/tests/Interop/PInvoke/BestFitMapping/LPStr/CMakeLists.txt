
project (LPStr_BestFitMappingNative)
include ("${CLR_INTEROP_TEST_ROOT}/Interop.cmake")
set(SOURCES
    BestFitMappingNative.cpp
)

add_library (LPStr_BestFitMappingNative SHARED ${SOURCES})
target_link_libraries(LPStr_BestFitMappingNative PRIVATE ${LINK_LIBRARIES_ADDITIONAL})
# add the install targets
install (TARGETS LPStr_BestFitMappingNative DESTINATION bin)

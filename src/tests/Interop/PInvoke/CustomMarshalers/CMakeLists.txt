project (CustomMarshalersNative)
include_directories(${INC_PLATFORM_DIR})
set(SOURCES CustomMarshalersNative.cpp )

# add the executable
add_library (CustomMarshalersNative SHARED ${SOURCES})
target_link_libraries(CustomMarshalersNative PRIVATE ${LINK_LIBRARIES_ADDITIONAL})

# add the install targets
install (TARGETS CustomMarshalersNative DESTINATION bin)

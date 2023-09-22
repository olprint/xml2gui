
project(Example)

find_library(
	MCXML mcxml32
 	PATHS "./lib"
)

add_executable(Example ../Example.c)
target_link_libraries(Example PRIVATE ${MCXML})

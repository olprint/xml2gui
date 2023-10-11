
project(Example)

find_library(
	MCXML mcxml64
	# MCXML libmcxml64 # for Visual Studio.
 	PATHS "../lib_C,C++(64)/"
)

add_executable(Example Example.c)
target_link_libraries(Example PRIVATE ${MCXML})

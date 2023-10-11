
project(Example)

find_library(
	MCXML mcxml32
	# MCXML libmcxml32 # for Visual Studio.
 	PATHS "../lib_C,C++(32)/"
)

add_executable(Example Example.c)
target_link_libraries(Example PRIVATE ${MCXML})

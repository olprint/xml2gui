fn main() {
    println!("cargo:rustc-link-search=native=./dll");
    println!("cargo:rustc-link-lib=dylib=mcxml64");
}

use std::ffi::CString;
mod xml2gui;
use xml2gui as g;

#[link(name = "mcxml64")] 
extern "C" {}

fn main() {
    let xml = "
		<App
			id=\"app\"
			width=\"800\"
			height=\"600\"
			background=\"#121212\"
			>
		</App>
		";
    unsafe {
        let cpp = CString::new(xml).unwrap();
        g::mcxml_loop(cpp.as_ptr());
    }
}


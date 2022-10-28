use galgehuman::Galge;

#[test]
fn rate_buchstaben_input_e_return_exxx() {
    let input = "eins".to_string();
    let mut g = Galge::new(input);
    let result = g.rate_buchstaben('e');
    assert_eq!(result, "exxx");
}

#[test]
fn rate_buchstaben_input_empty_return_xxxx() {
    let input = "eins".to_string();
    let mut g = Galge::new(input);
    let result = g.rate_buchstaben(' ');
    assert_eq!(result, "xxxx");
}
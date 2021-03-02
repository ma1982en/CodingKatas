#[cfg(test)]
mod tests {    
    use split_in_pairs::solution;

    #[test]
    fn basic() {
        assert_eq!(solution("a"), ["a_"]);
        assert_eq!(solution("abcdef"), ["ab", "cd", "ef"]);
        assert_eq!(solution("abcdefg"), ["ab", "cd", "ef", "g_"]);
        assert_eq!(solution(""), [] as [&str; 0]);
    }
}
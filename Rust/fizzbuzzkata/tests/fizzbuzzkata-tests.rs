#[cfg(test)]
mod tests {
    use fizzbuzzkata::convert;

    #[test]
    fn test_inside_0_return_0() {
        assert_eq!(convert(0),"0");
    }

    #[test]
    fn test_inside_1_return_1() {
        assert_eq!(convert(1),"1");
    }

    #[test]
    fn test_inside_2_return_2() {
        assert_eq!(convert(2),"2");
    }

    #[test]
    fn test_inside_3_return_fizz() {
        assert_eq!(convert(3),"FIZZ");
    }

    #[test]
    fn test_inside_4_return_4() {
        assert_eq!(convert(4),"4");
    }

    #[test]
    fn test_inside_5_return_buzz() {
        assert_eq!(convert(5),"BUZZ");
    }

    #[test]
    fn test_inside_6_return_fizz() {
        assert_eq!(convert(6),"FIZZ");
    }

    #[test]
    fn test_inside_9_return_fizz() {
        assert_eq!(convert(9),"FIZZ");
    }

    #[test]
    fn test_inside_10_return_buzz() {
        assert_eq!(convert(10),"BUZZ");
    }

    #[test]
    fn test_inside_12_return_fizz() {
        assert_eq!(convert(12),"FIZZ");
    }

    #[test]
    fn test_inside_15_return_fizzbuzz() {
        assert_eq!(convert(15),"FIZZBUZZ");
    }

    #[test]
    fn test_inside_30_return_fizzbuzz() {
        assert_eq!(convert(30),"FIZZBUZZ");
    }
}
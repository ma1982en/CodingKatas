#[cfg(test)]
mod tests {
    use russianpawnmultiplication::calculate;

    #[test]
    fn test_para1_0_para2_0_return_0() {
        assert_eq!(calculate(0,0),0);
    }

    #[test]
    fn test_para1_1_para2_1_return_1() {
        assert_eq!(calculate(1,1),1);
    }

    #[test]
    fn test_para1_1_para2_2_return_2() {
        assert_eq!(calculate(1,2),2);
    }

    #[test]
    fn test_para1_2_para2_1_return_2() {
        assert_eq!(calculate(2,1),2);
    }

    #[test]
    fn test_para1_2_para2_2_return_4() {
        assert_eq!(calculate(2,2),4);
    }

    #[test]
    fn test_para1_3_para2_3_return_9() {
        assert_eq!(calculate(3,3),9);
    }

    #[test]
    fn test_para1_5_para2_8_return_40() {
        assert_eq!(calculate(5,8),40);
    }

    #[test]
    fn test_left_47_right_42_return_1974() {
        assert_eq!(calculate(47,42),1974);
    }
}
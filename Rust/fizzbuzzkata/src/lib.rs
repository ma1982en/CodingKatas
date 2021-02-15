pub fn convert(parameter: i32) -> String{

    if parameter == 0
    {
        return "0".to_string();
    }

    if parameter % 3 == 0 && parameter % 5 == 0
    {
        return "FIZZBUZZ".to_string();
    }

    if parameter % 3 == 0
    {
        return "FIZZ".to_string();
    }

    if parameter % 5 == 0
    {
        return "BUZZ".to_string();
    }

    return parameter.to_string();
}

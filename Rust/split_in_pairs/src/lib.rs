pub fn solution(s: &str) -> Vec<String> {
    let mut data: Vec<String> = Vec::new();
    if s.is_empty() {
        return data;
    }
    //convert to chars collection
    let input_chars: Vec<char> = s.chars().collect();
    let maxcount = input_chars.len();
    let mut index = 0;
    while index < maxcount {
        let pair_part1 = input_chars[index].to_string();
        //special case not mod 2
        if index + 1 == maxcount {
            let pair_part2  = "_".to_string();
            let pair = [pair_part1,pair_part2].join("");
            data.push(pair);
        } else {
            let pair_part2 = input_chars[index + 1].to_string();
            let pair = [pair_part1,pair_part2].join("");
            data.push(pair);
        }
        //increment
        index = index + 2;
    }
    return data;
}
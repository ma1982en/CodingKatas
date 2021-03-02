pub fn calculate (left: i32,right: i32) -> i32 {

    if left == 0 || right == 0 {
        return 0;
    }
    
    if left == 1 {
        return right;
    }

    if right == 1 {
        return left;
    }

    let mut rights: Vec<i32> = Vec::new();
    let mut lefts: Vec<i32> = Vec::new();
    lefts.push(left);
    rights.push(right);

    let mut lefttmp = left;
    let mut righttmp = right;
    loop{
       lefttmp = lefttmp / 2;
       lefts.push(lefttmp);

       righttmp = righttmp * 2;
       rights.push(righttmp);

       if lefttmp == 1 {
           break;
       }
    }

    for i in 0..lefts.len() {
        if lefts[i] % 2 == 0 {
            rights[i] = 0;
        }
    }

    let mut result = 0;
    for i in 0..rights.len() {
        result += rights[i];

    }

    return result;
}





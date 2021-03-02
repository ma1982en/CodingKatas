pub fn is_prime(x: i64) -> bool {    
    if x < 2 {
        return false;
    }
    if x == 2 {
        return true;
    }
    let upperlimit = (x as f64).sqrt() as i64 + 1;            
    let mut index = 2;
    while index < upperlimit {
        if x % index == 0 {
            return false;
        }
        index = index + 1;
    }
    
    return true;    
}
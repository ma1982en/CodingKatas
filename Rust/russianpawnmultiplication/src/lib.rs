use std::collections::LinkedList;

pub fn calculate (left: i32, right: i32) -> i32 {

    if left == 0 || right == 0 {
        return 0;
    }
    
    if left == 1 {
        return right;
    }

    if right == 1 {
        return left;
    }

    let mut rights: LinkedList<i32> = LinkedList::new();
    let mut lefts: LinkedList<i32> = LinkedList::new();
    lefts.push_back(left);
    rights.push_back(right);
    loop{
       let val1: i32 = left /2;
       println!("left: {}",val1);
       lefts.push_back(val1);

       let val2: i32 = right * 2;
       println!("right: {}",val2);
       rights.push_back(val2);

       if val1 == 1 {
           break;
       }
    }

    let mut resultlist: LinkedList<i32> = LinkedList::new();
    let mut iterright = rights.iter();
    for elem in lefts.iter() {
        let nextright = iterright.next();
        if elem % 2 == 0 {            
            match nextright {
                Some(n) => println!("1 LEFT = {} right = {}",elem,n),
                None => break,
            };            
        } else {
            match nextright {
                Some(n) => {
                    println!("2 LEFT = {} right = {}",elem,n);
                    resultlist.push_back(*n);
            },
                None => break,
            };
            
        }        
    }

    let mut result: i32 = 0;
    for elem in resultlist.iter() {
        println!("Value {}",elem);
        result += elem;        
    }
    return result;
}





//Implementierung 

pub struct Galge {
    search_word: String,
    result_word: Vec<char>
}

impl Galge {   
    pub fn new(search_word: String) -> Galge {
        Galge { 
            search_word: search_word,
            result_word: Vec::new()
        }        
    }

    pub fn rate_buchstaben(&mut self, buchstabe: char) -> String {
        if buchstabe.is_alphabetic() == false {
            return "xxxx".to_string();
        }

        //initialisieren
        if self.search_word.len() != self.result_word.len() {
            for _ in self.search_word.chars() {
                self.result_word.push('_')
            }
        }


        if self.search_word.contains(&buchstabe.to_string()) == true {
           //let a = self.search_word.chars().position('e');
            return self.result_word.iter().cloned().collect::<String>();
        }

        return self.result_word.iter().cloned().collect::<String>();
    }
}
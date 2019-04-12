module _3and5s

let threeOrFive x = 
    if x % 3 = 0 || x % 5 = 0 then x else 0

let threeandfives x = 
    let rec sum list = 
        match list with
        | [] -> 0
        | x::xs -> (threeOrFive x) + sum xs
    sum [0..x]
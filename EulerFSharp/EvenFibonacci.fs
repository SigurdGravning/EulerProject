module EvenFibonacci

let rec evenFib x y z = 
    let z = y
    let y = x    
    let x = z + y
    match x with
        | i when i > 4000000 -> 0
        | j when j % 2 = 0 -> j + evenFib x y z
        | _ -> evenFib x y z
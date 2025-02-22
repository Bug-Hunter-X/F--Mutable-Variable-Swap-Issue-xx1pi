let mutable x = 10
let mutable y = 20

let swap x y =
    let temp = x
    x <- y
    y <- temp

printf "%d %d" x y //This will print 10 20 instead of 20 10 because the swap function does not affect the outer scope variables
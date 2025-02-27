module Tests

open Expecto
open FsCheck

let ordered (xs: 'a list) = xs = (xs |> List.sort)
let rec insert nx xs =
    match xs with
    | []                 -> [nx]
    | x::xs when nx < x -> nx::x::xs
    | x::xs              -> x::insert nx xs
    


[<Tests>]
let tests =
  testList "Chapter Properties" [
    
    let revRevIsOrig (xs:list<int>) = List.rev(List.rev xs) = xs
    
    testProperty "Reverse of reverse of a list is the original list" <|
      revRevIsOrig

    let insertKeepsOrder (x:int) (xs: int list) = ordered xs ==> ordered (insert x xs)
    
    testProperty "Conditional property" <|
        skiptest "Fails because Arguments exhaust" insertKeepsOrder
     
    let isEven n = n % 2 = 0
    let isOdd = not << isEven
     
    let evenIsFollowedByEven (n: int) = isEven n ==> isOdd (n + 1)
    testProperty "even is followed by odd" <|
        evenIsFollowedByEven
  ]

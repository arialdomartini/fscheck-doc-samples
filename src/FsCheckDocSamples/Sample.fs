module Tests

open Expecto

[<Tests>]
let tests =
  testList "Chapter Properties" [
    
    let revRevIsOrig (xs:list<int>) = List.rev(List.rev xs) = xs
    
    testProperty "Reverse of reverse of a list is the original list" <|
      revRevIsOrig
  ]

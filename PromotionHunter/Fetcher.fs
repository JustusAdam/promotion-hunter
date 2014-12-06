namespace PromotionHunter

open System

type Fetcher() = 
    class end

    
module tools =
    type Store = {
        name:string
        url:String
    }

    type Article = {
        price: float
        reduction:float
        description:String
        name:String
        store:Store
    }
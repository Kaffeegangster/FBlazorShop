﻿namespace FBlazorShop.EF
open Microsoft.EntityFrameworkCore
open FBlazorShop.App.Model

type PizzaStoreContext = 
    inherit DbContext

    [<DefaultValue>] 
    val mutable private specials : DbSet<PizzaSpecial> 

    new () = {}
    new (options : DbContextOptions) = { inherit DbContext(options) }
    member this.Specials 
        with get() = this.specials 
        and private set v = this.specials <- v

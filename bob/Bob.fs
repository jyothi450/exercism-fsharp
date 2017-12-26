module Bob

let response (input: string): string =
    let isQuestion (x : string) = x.EndsWith('?')
    let isYell (x:string) = Seq.exists System.Char.IsLetter x && x = x.ToUpper()
    let isForcefulQuestion (x:string) = isQuestion(x) && isYell(x)
    let trimmedInput = input.Trim()

    match trimmedInput with
        | _ when trimmedInput |> System.String.IsNullOrWhiteSpace -> "Fine. Be that way!"
        | _ when trimmedInput |> isForcefulQuestion -> "Calm down, I know what I'm doing!"
        | _ when trimmedInput |> isQuestion -> "Sure."
        | _ when trimmedInput |> isYell -> "Whoa, chill out!"
        | _ -> "Whatever."

        
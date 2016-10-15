defmodule NextBiggerNumber do
    def nextBigger(n) do
        result = -1
        max = maxed_number(n)
        Enum.each(n+1..max, fn(x) -> 
            IO.puts  "#{max} == #{maxed_number(x)}?" 
            if(max == maxed_number(x)) do
                result = x
            end
        end)
        result
    end

    def maxed_number(n) do
        Integer.digits(n) |> Enum.sort |> Enum.reverse |> Integer.undigits    
    end
end

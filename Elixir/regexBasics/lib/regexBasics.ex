defmodule RegexBasics do
    def digit?(s) do
        #String.length(s) == 1 and Regex.match?(~r/^\d$/, s)
        Regex.match?(~r/^\d\z/, s)
    end
end

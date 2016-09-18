defmodule PriceOfMangoes do
    def mango(quantity, price) do
        div(quantity, 3) * 2 * price + rem(quantity, 3) * price
    end
end

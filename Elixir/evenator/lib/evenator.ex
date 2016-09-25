defmodule Evenator do
  def even?(n) do
    !is_float(n) and rem(n, 2) == 0
  end
end

defmodule PrinterErrors do
  def printer_error(s) do
    "3" <> "/" <> Integer.to_string(String.length(s))
    # Enum.reduce(Enum.chunk(String.to_char_list("HellO"),1), %{}, fn(x, y) -> y + 1 end); kleine Idee
  end
end

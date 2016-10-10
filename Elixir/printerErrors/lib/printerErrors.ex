defmodule PrinterErrors do
  def printer_error(s) do            
    reduced = Regex.replace(~r/[n-z]/, s, "")    
    result = "#{String.length(s) - String.length(reduced)}/#{Integer.to_string(String.length(s))}"  
    result
  end
end

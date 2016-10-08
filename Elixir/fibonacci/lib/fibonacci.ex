defmodule Fibonacci do
    def of(0), do: 0
    def of(1), do: 1
    def of(n) do
        of(n-1) + of(n-2)
    end

    def with_task(n) do
        IO.puts "Start the task"
        worker = Task.async(fn -> of(20) end)
        IO.puts "Do something else"
        #
        IO.puts "Wait for the task"
        result = Task.await(worker)
        IO.puts "The result is #{result}"
        result
    end

    def mapp do
        list = Enum.concat([1..1000])
        result = Enum.map(list, fn(x) -> x * 2 end)
        IO.inspect result
        result 
    end
end

/**
 * Created by mba on 05.02.17.
 */
data class Customer(var Name: String, var Email: String)

fun main(args: Array<String>) {
    var customer = Customer("Marc", "marc.biegota@5minds.de")
    println(customer.Name)

    var arr = arrayOf("a", "b", "c")
    arr[0] = "test"

    for (item in arr){
        println(item)
    }


    arr.reversedArray().forEach { i -> println(i) }

    println(arr[1])
}
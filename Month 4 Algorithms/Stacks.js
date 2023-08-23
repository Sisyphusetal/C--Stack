/**
 * Class to represent a stack using an array to store the stacked items.
 * Follows a LIFO (Last In First Out) order where new items are stacked on
 * top (back of array) and removed items are removed from the top / back.
 */
class Stack {
    /**
     * The constructor is executed when instantiating a new Stack() to construct
     * a new instance.
     * @returns {Stack} This new Stack instance is returned without having to
     *    explicitly write 'return' (implicit return).
     */
    constructor() {
        this.items = [];
    }



    /**
     * Adds a new given item to the top / back of this stack.
     * - Time: O(1) constant.
     * - Space: O(1) constant.
     * @param {any} item The new item to be added to the top / back.
     * @returns {number} The new length of this stack.
     */
    push(item) { 

    }



    /**
     * Removes the top / last item from this stack.
     * - Time: O(1) constant.
     * - Space: O(1) constant.
     * @returns {any} The removed item or undefined if this stack was empty.
     */
    pop() { 

    }



    /**
     * Retrieves the top / last item from this stack without removing it.
     * - Time: O(1) constant.
     * - Space: O(1) constant.
     * @returns {any} The top / last item of this stack.
     */
    peek() { 

    }



    /**
     * Returns whether or not this stack is empty.
     * - Time: O(1) constant.
     * - Space: O(1) constant.
     * @returns {boolean}
     */
    isEmpty() { 

    }



    /**
     * Returns the size of this stack.
     * - Time: O(1) constant.
     * - Space: O(1) constant.
     * @returns {number} The length.
     */
    size() { 

    }
}

let empty = new Stack();
let myList = new Stack()
// myList.push(8)
// myList.push(4)
// myList.push(10)
// myList.push(15)
// myList.push(20)
// myList.push(30)
// myList.push(40);
// console.log(myList.peek());
// console.log(empty.isEmpty())
// console.log(myList.isEmpty())
// console.log(myList.size());
// console.log(myList.isEmpty());
// console.log(myList.pop());
// console.log(myList.peek());
// console.log(myList.push(5));
// console.log(myList.push(7));
// console.log(myList.peek());

/*
    *** Bonus
    Recreate the stack class using a singly linked list to store the items instead of an array
    Stacks are linear data structures in that you have one element
*/
class StackNode {
    constructor(data) {
        this.data = data;
        this.next = null;
    }
}

class LinkedListStack {
    constructor() {
        this.head = null;
    }

    /**
     * Adds a new given item to the top / back of this stack.
     * - Time: O(1) constant.
     * - Space: O(1) constant.
     * @param {any} item The new item to be added to the top / back.
     * @returns {number} The new length of this stack.
     */
    push(item) { 
        let newNode = new StackNodeZ(data);

        newNode.next = this.head;
        this.head = newNode;

        return newNode;
    }



    /**
     * Removes the top / last item from this stack.
     * - Time: O(1) constant.
     * - Space: O(1) constant.
     * @returns {any} The removed item or undefined if this stack was empty.
     */
    pop() { 
        if(this.isEmpty)
    }



    /**
     * Retrieves the top / last item from this stack without removing it.
     * - Time: O(1) constant.
     * - Space: O(1) constant.
     * @returns {any} The top / last item of this stack.
     */
    peek() { 

    }



    /**
     * Returns whether or not this stack is empty.
     * - Time: O(1) constant.
     * - Space: O(1) constant.
     * @returns {boolean}
     */
    isEmpty() { 

    }



    /**
     * Returns the size of this stack.
     * - Time: O(1) constant.
     * - Space: O(1) constant.
     * @returns {number} The length.
     */
    size() { 

    }



    // Time: O(n) linear, n = list length
    // Space: O(n)
    print() {
        let runner = this.head;
        let vals = "";

        while (runner) {
            vals += `${runner.data}${runner.next ? ", " : ""}`;
            runner = runner.next;
        }
        console.log(vals);
        return vals;
    }
}

let emptyLLS = new LinkedListStack();
let myListLLS = new LinkedListStack()
myListLLS.push(10)
myListLLS.push(20)
myListLLS.push(30)
myListLLS.push(40)
myListLLS.push(50)
myListLLS.push(60)
console.log(myListLLS.isEmpty());
console.log(myListLLS.peek());
console.log(myListLLS.size());
console.log(myListLLS.pop());
console.log(myListLLS.size());
console.log(myListLLS.contains(60));
console.log(myListLLS.contains(50));
myListLLS.print()
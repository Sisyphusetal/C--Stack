/**
 * A class to represent a single item of a SinglyLinkedList that can be
 * linked to other Node instances to form a list of linked nodes.
 */

class ListNode {

    /**
     * Constructs a new Node instance. Executed when the 'new' keyword is used.
     * @param {any} data The data to be added into this new instance of a Node.
     *    The data can be anything, just like an array can contain strings,
     *    numbers, objects, etc.
     * @returns {ListNode} A new Node instance is returned automatically without
     *    having to be explicitly written (implicit return).
     */

    constructor(data) {
        this.data = data;

        /**
       * This property is used to link this node to whichever node is next
       * in the list. By default, this new node is not linked to any other
       * nodes, so the setting / updating of this property will happen sometime
       * after this node is created.
       *
       * @type {ListNode|null}
       */

        this.next = null;
    }
}

/**
* This class keeps track of the start (head) of the list and to store all the
* functionality (methods) that each list should have.
*/
class SinglyLinkedList {
    /**
     * Constructs a new instance of an empty linked list that inherits all the
     * methods.
     * @returns {SinglyLinkedList} The new list that is instantiated is implicitly
     *    returned without having to explicitly write "return".
     */
    constructor() {
        /** @type {ListNode|null} */
        this.head = null;
    }

    /**
     * Determines if this list is empty.
     * - Time: O(?).
     * - Space: O(?).
     * @returns {boolean}
     */

    isEmpty() {
        //return this.head === null;
        //Or some sort of if statement returning this logic
        if (this.head === null) {
            return true;
        }

        else {
            return false
        }
    }

    /**
     * Creates a new node with the given data and inserts it at the back of
     * this list.
     * - Time: O(?).
     * - Space: O(?).
     * @param {any} data The data to be added to the new node.
     * @returns {SinglyLinkedList} This list.
     */

    insertAtBack(value) {
        if (this.isEmpty()) {
            this.head = new ListNode(value)
            return this;
        }
        let runner = this.head;

        while (runner.next != null) {
            runner = runner.next;
        }

        runner.next = new ListNode(value)
        return this;

    }

    /**
     * Creates a new node with the given data and inserts it at the back of
     * this list.
     * - Time: O(?).
     * - Space: O(?).
     * @param {any} data The data to be added to the new node.
     * @param {?ListNode} runner The current node during the traversal of this list
     *    or null when the end of the list has been reached.
     * @returns {SinglyLinkedList} This list.
     */
    insertAtBackRecursive(data, runner = this.head) {
        if (this.isEmpty()) {
            this.head = new ListNode(data);
            return this;
        }
        // check if next node is empty
        if (runner.next !== null) {
            // if next node is not empty, recursive call to set runner to next node
            return this.insertAtBackRecursive(data, runner = runner.next);
        } else { // if next node IS empty
            // set next node to equal new data
            runner.next = new ListNode(data);
            return this;
        }
    }

    /**
     * Calls insertAtBack on each item of the given array.
     * - Time: O(n * m) n = list length, m = arr.length.
     * - Space: O(1) constant.
     * @param {Array<any>} vals The data for each new node.
     * @returns {SinglyLinkedList} This list.
     */
    insertAtBackMany(vals) {
        for (const item of vals) {
            this.insertAtBack(item);
        }
        return this;
    }
    /**
 * Creates a new node with the given data and inserts that node at the front
 * of this list.
 * - Time: (?).
 * - Space: (?).
 * @param {any} data The data for the new node.
 * @returns {SinglyLinkedList} This list.
 */
    insertAtFront(data) {
        let newNode = new ListNode(data);

        newNode.next = this.head;

        this.head = newNode;

        return this;
    }

    /**
     * Removes the first node of this list.
     * - Time: (?).
     * - Space: (?).
     * @returns {any} The data from the removed node.
     */
    removeHead() {
        if (!this.head) {
            return;
        }
        this.head = this.head.next;
        return this;
    }

    // EXTRA
    /**
     * Calculates the average of this list.
     * - Time: (?).
     * - Space: (?).
     * @returns {number|NaN} The average of the node's data.
     */
    average() {
        // Check if the list is empty. If so, return null.
        if (this.isEmpty()) {
            return null;
        }
        // Initialize variables to keep track of the sum of data and the count of nodes in the list.
        let runner = this.head;
        let sum = 0;
        let cnt = 0;
        // Iterate through each node in the list.
        while (runner) {
            // Increment the count of nodes.
            cnt++;
            // Add the data of the current node to the sum.
            sum += runner.data;
            // Move the runner to the next node.
            runner = runner.next;
        }
        // Calculate and return the average by dividing the sum by the count of nodes.
        return sum / cnt;
    }

    /**
 * Removes the last node of this list.
 * - HINT: Figuring out a way to find the SECOND TO LAST node will be immensely helpful!
 * - Time: O(?).
 * - Space: O(?).
 * @returns {any} The data from the node that was removed.
 */
    removeBack() {
        if (this.isEmpty()) {
            return null;
        }

        if (this.head.next == null) {
            return null;
        }

        let runner = this.head;

        while (runner.next.next != null) {
            runner = runner.next;
        }

        runner.next = null;

        return this;
    }

    /**
 * Determines whether or not the given search value exists in this list.
 * - Time: O(?).
 * - Space: O(?).
 * @param {any} val The data to search for in the nodes of this list.
 * @returns {boolean}
 */
    contains(val) {
        if (this.isEmpty()) {
            return null;
        }

        let runner = this.head;
        let valueIsPresent = false;

        //alternatively, 'runner.next != null' can simply be replaced by 'runner'
        //due to null being falsy in nature.
        while (runner.next != null) {
            if (runner.data == val) {
                valueIsPresent = true;
            }
            runner = runner.next;
        }

        console.log(valueIsPresent);
    }

    /** EXTRA
 * Determines whether or not the given search value exists in this list.
 * - Time: O(?).
 * - Space: O(?).
 * @param {any} val The data to search for in the nodes of this list.
 * @param {?ListNode} current The current node during the traversal of this list
 *    or null when the end of the list has been reached.
 * @returns {boolean}
 */
    containsRecursive(val, current = this.head) {
        // Base case: If we reach the end of the list (current is null),
        // we didn't find the value, so return false.
        if (current === null) {
            return false;
        }
        // Check if the current node's data is equal to the given value.
        if (current.data === val) {
            // If we find the value in the current node, return true.
            return true;
        }
        // Recursive case: Call the function again with the next node in the linked list.
        // This will continue the search through the list until the base case is reached.
        return this.containsRecursive(val, current.next);
    }

    // EXTRA
    /**
     * Recursively finds the maximum integer data of the nodes in this list.
     * - Time: O(?).
     * - Space: O(?).
     * @param {ListNode} runner The start or current node during traversal, or null
     *    when the end of the list is reached.
     * @param {ListNode} maxNode Keeps track of the node that contains the current
     *    max integer as it's data.
     * @returns {?number} The max int or null if none.
     */
    recursiveMax(runner = this.head, maxNode = this.head) {
        // Base case: If the list is empty (head is null), return null.
        if (this.head === null) {
            return null;
        }
        // Base case: If we have reached the end of the list (runner is null),
        // return the data of the node containing the maximum value.
        if (runner === null) {
            return maxNode.data;
        }
        // Compare the data of the current node (runner) with the maximum node (maxNode).
        // If the data of the current node is greater than the data of the maximum node,
        // update maxNode to point to the current node.
        if (runner.data > maxNode.data) {
            maxNode = runner;
        }
        // Recursive case: Call the function again with the next node in the linked list
        // and the updated maxNode.
        // This will continue to traverse through the list, updating maxNode whenever a larger value is found.
        return this.recursiveMax(runner.next, maxNode);
    }

    /**
   * Retrieves the data of the second to last node in this list.
   * - Time: O(?).
   * - Space: O(?).
   * @returns {any} The data of the second to last node or null if there is no
   *    second to last node.
   */
    secondToLast() {
        if(this.isEmpty() || this.head.next == null) {
            return null;
        }

        let runner = this.head;
        
        
        while (runner.next.next != null) {
            runner = runner.next;
        }

        return runner.data;
    }

    /**
     * Removes the node that has the matching given val as it's data.
     * - Time: O(?).
     * - Space: O(?).
     * @param {any} val The value to compare to the node's data to find the
     *    node to be removed.
     * @returns {boolean} Indicates if a node was removed or not.
     */
    removeVal(val) {
        if(this.isEmpty()) {
            return null;
        }

        let runner = this.head;

        if(runner.data == val) {
            this.head = runner.next;
            return true;
        }

        while(runner.next != null || runner != null) {
            if(runner.next.data == val) {
                runner.next = runner.next.next;
                return true;
            }
            runner = runner.next;
        }

        return false;
    }

    // EXTRA
    /**
     * Inserts a new node before a node that has the given value as its data.
     * - Time: O(?).
     * - Space: O(?).
     * @param {any} newVal The value to use for the new node that is being added.
     * @param {any} targetVal The value to use to find the node that the newVal
     *    should be inserted in front of.
     * @returns {boolean} To indicate whether the node was pre-pended or not.
     */
    prepend(newVal, targetVal) { 

    }

    /**
     * Converts this list into an array containing the data of each node.
     * - Time: O(n) linear.
     * - Space: O(n).
     * @returns {Array<any>} An array of each node's data.
     */

    /**
     * Converts this list into an array containing the data of each node.
     * - Time: O(n) linear.
     * - Space: O(n).
     * @returns {Array<any>} An array of each node's data.
     */
    toArr() {
        const arr = [];
        let runner = this.head;

        while (runner) {
            arr.push(runner.data);
            runner = runner.next;
        }
        return arr;
    }

    print() {
        if (this.isEmpty()) {
            console.log("This list is empty");
            return this;
        }
        // We need to initialize an empty string
        let toPrint = "";
        // And start a runner at the head of the list.
        let runner = this.head;
        // We want to perform something every time runner isn't null
        while (runner != null) {
            // Add the new value and an arrow (oh so fancy, I know!)
            // to the string we want to print
            toPrint += `${runner.data} -> `;
            // And move runner to the next node. This is gonna be your 
            // bread and butter when it comes to linked lists
            runner = runner.next;
        }
        // What good is our print list method if it doesn't console log?!
        console.log(toPrint);
        // And just so we can chain methods (idk why you'd want to chain from print list,
        // but why not), just return this.
        return this;
    }
}



/******************************************************************* 
Multiple test lists already constructed to test your methods on.
Below commented code depends on insertAtBack method to be completed,
after completing it, uncomment the code.
  */
const emptyList = new SinglyLinkedList();

// const singleNodeList = new SinglyLinkedList().insertAtBackMany([1]);
// const biNodeList = new SinglyLinkedList().insertAtBackMany([1, 2]);
// const firstThreeList = new SinglyLinkedList().insertAtBackMany([1, 2, 3]);
// const secondThreeList = new SinglyLinkedList().insertAtBackMany([4, 5, 6]);
// const unorderedList = new SinglyLinkedList().insertAtBackMany([
//   -5, -10, 4, -3, 6, 1, -7, -2,
// ]);

/* node 4 connects to node 1, back to head */
// const perfectLoopList = new SinglyLinkedList().insertAtBackMany([1, 2, 3, 4]);
// perfectLoopList.head.next.next.next = perfectLoopList.head;

/* node 4 connects to node 2 */
// const loopList = new SinglyLinkedList().insertAtBackMany([1, 2, 3, 4]);
// loopList.head.next.next.next = loopList.head.next;

// const sortedDupeList = new SinglyLinkedList().insertAtBackMany([
//   1, 1, 1, 2, 3, 3, 4, 5, 5,
// ]);

// Print your list like so:
// console.log(firstThreeList.toArr());



let myList = new SinglyLinkedList();
myList.insertAtBack(1)
//.insertAtBack(2).insertAtBack(3).insertAtBack(4).insertAtBack(5).insertAtBack(6);
// myList.print();
myList.removeBack()
//.removeBack();
myList.print();
// myList.contains(2);
// myList.contains(14);

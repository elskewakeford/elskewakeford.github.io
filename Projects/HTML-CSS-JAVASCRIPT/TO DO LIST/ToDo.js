// alert("Connected!");

let instruction = prompt("What would you like to do?");
const ToDo = ['Collect Chicken Eggs', 'Shower']

while (instruction !== 'quit' && instruction !== 'q') {

    if (instruction === 'list') {
        console.log('**********');
        for (let i = 0; i < ToDo.length; i++) {
            console.log(`${i + 1}: ${ToDo[i]}`);
        }
        console.log('**********');

    } else if (instruction === 'new') {
        const newTodo = prompt('OK, What is the new to-do?');
        ToDo.push(newTodo);
        console.log(`${newTodo} has been added to the list`);

    } else if (instruction === 'delete') {
        const remove = prompt('Inter an index to delete!');
        parseInt(remove);
        if (remove <= ToDo.length) {
            const deleted = ToDo.splice(remove - 1, 1);
            console.log(`${deleted} has been removed!`);
        } else {
            console.log('!!');
        }

    }

    instruction = prompt("What would you like to do?");

}
console.log("You QUIT the app");
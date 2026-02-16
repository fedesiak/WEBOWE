import { type User, users } from "./mod1.js";
import fs from "fs/promises";
import readline from "readline";

async function main() {

    const name = await ask("Podaj imię: ");
    const email = await ask("Podaj email: ");

    const newUser: User = {
        id: users.length + 1,
        name,
        email
    };

    users.push(newUser);

    console.log(`Dodano użytkownika: ${name}, ${email}`);

    
    for (const user of users) {
        console.log("User: " + user.name + " Email: " + user.email + ".");
        await fs.appendFile(
        "users.txt",
        `ID: ${user.id}, Name: ${user.name}, Email: ${user.email}\n`
    );
    }

    



   
}

function ask(question: string): Promise<string> {
    const rl = readline.createInterface({
        input: process.stdin,
        output: process.stdout
    });

    return new Promise((resolve) => {
        rl.question(question, (answer) => {
            rl.close();
            resolve(answer);
        });
    });
}

main();

export type User = {
    id: number;
    name: string;
    email: string;
};

export const users: User[] = [
    {id: 1, name: "Alice", email: "alice@gmail.com"},
    {id: 2, name: "Piotr", email: "piotr@gmail.com"},
    {id: 3, name: "Pies", email: "pies@gmail.com"},
];
import React from 'react';
//import './Table.css';  

export default function Table({ columns = [], data = [] }) { 
    return (
        <table border="1">
            <thead>
                <tr>
                    {columns.map((col) => (
                        <th key={col}>{col}</th>
                    ))}
                </tr>
            </thead>
            <tbody>
                {data.map((row, rowIndex) => (
                    <tr key={rowIndex}>
                        {columns.map((col) => (
                            <td key={col}>{row[col]}</td>
                        ))}
                    </tr>
                ))}
            </tbody>
        </table>
    );
}
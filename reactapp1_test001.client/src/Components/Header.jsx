import React from 'react';
import { Link } from 'react-router-dom';
import './Header.css';

export default function Header() {
    return (
        <div className="sidebar">
            <nav>
                <Link to="/status">貸出状況</Link>
                <Link to="/devices">機器一覧</Link>
                <Link to="/users">ユーザー一覧</Link>
                <Link to="/logout" className="logout-button">LOGOUT</Link>
            </nav>
        </div>
    );
}
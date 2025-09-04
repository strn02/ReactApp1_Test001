import React from 'react';
import { BrowserRouter, Routes, Route } from 'react-router-dom';
import Header from './Components/Header';
import StatusPage from './Components/Pages/StatusPage';
import DevicesPage from './Components/Pages/DevicesPage';
import UsersPage from './Components/Pages/UsersPage';
import LogoutPage from './Components/LogoutPage';

function App() {
    return (
        <BrowserRouter>
            <Header />
            <div className="page-container">
                <Routes>
                    <Route path="/" element={<StatusPage />} />
                    <Route path="status" element={<StatusPage />} />
                    <Route path="devices" element={<DevicesPage />} />
                    <Route path="users" element={<UsersPage />} />
                    <Route path="logout" element={<LogoutPage />} />
                </Routes>
            </div>
        </BrowserRouter>
    );
}

export default App;
import React from 'react';
import Table from '../Table';
import Header from '../Header';
import './Page.css';

export default function DevicesPage() {

    const columns = ['ID', '名前', 'メールアドレス'];
    const data = [
        {
            ID: 1, 名前: '山田太郎', メールアドレス: 'tanaka@example.com'
        },
        {
            ID: 2, 名前: '鈴木花子', メールアドレス: 'suzuki@example.com'
        }];

    return (
        <div className="container">
            <Header />
            <div className="main-content">
                <h1>機器一覧</h1>
                <Table columns={columns} data={data} />
            </div>
        </div>
    )
};
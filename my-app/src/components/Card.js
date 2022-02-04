import React from 'react';
import './Card.css';
import {  useNavigate} from "react-router-dom";

export default function Card(props) {

    const navigation = useNavigate();

    return (
        <div  onClick={() => {navigation(props.pageName);}} className="card hvr-grow"  >
            <h3   className="card__title">{props.title}</h3>
            {props.icon}
        </div>
        );
}

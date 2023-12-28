﻿import { createRoot } from 'react-dom/client';
import React from 'react';
import FormManager from '../components/formManager.js';

class VideoGameForm extends React.Component {
    constructor(props) {
        super(props);
    }

    render() {
        return (
            <div className="small main-content container">
                <FormManager
                    title={localization.VideoGame}
                    rows={[
                        {
                            label: localization.Name,
                            property: 'Name',
                            required: true
                        }
                    ]}
                />
            </div>
        );
    }
}

createRoot(document.getElementById('root')).render(<VideoGameForm />);